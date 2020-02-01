# 适配器模式

将一个类的接口转换成客户希望的另外一个接口，使得原本由于接口不兼容而不能一起工作的那些类能一起工作。

生活中最贴切的例子就是变压充电器，将220v电压转换为手机能接受的5v电压，或者是将三孔转换为两空插头等等。

## 结构

* 目标接口（ITarget）：当前系统业务所期待的接口，它可以是抽象类或接口
* 被适配者（Adaptee）类：它是被访问和适配的现存组件库中的组件接口
* 适配器（Adapter）类：它是一个转换器，通过继承或引用适配者的对象，把适配者接口转换成目标接口，让客户按目标接口的格式访问适配者

## 类适配器

适配器实现目标接口，同时也继承被适配者。

类适配器因为使用了继承，不符合合成服用原则，也不符合单一职责原则，耦合大，所以不建议使用。

## 对象适配器

适配器只实现目标接口，然后将被适配者聚合到（一般是注入到）适配器中，在内部使用被是适配者完成系统所需要的接口。

## 例子

Sample中的例子比较符合现实生活，但是并不是很贴切实际开发的场景。下面给个实际运用适配器的例子：

在Mybatsi的logging包中，有一个Log接口：

```

public interface Log {

 boolean isDebugEnabled();

 boolean isTraceEnabled();

 void error(String s, Throwable e);

 void error(String s);

 void debug(String s);

 void trace(String s);

 void warn(String s);

}

```

该接口定义了Mybatis直接使用的日志方法，而Log接口具体由谁来实现呢？Mybatis提供了多种日志框架的实现，这些实现都匹配这个Log接口所定义的接口方法，最终实现了所有外部日志框架到Mybatis日志包的适配：比如对于Log4jImpl的实现来说，该实现持有了org.apache.log4j.Logger的实例，然后所有的日志方法，均委托该实例来实现。public class Log4jImpl implements Log {

```

 private static final String FQCN = Log4jImpl.class.getName();

 private Logger log;

 public Log4jImpl(String clazz) {
   log = Logger.getLogger(clazz);
 }

 @Override
 public boolean isDebugEnabled() {
   return log.isDebugEnabled();
 }

 @Override
 public boolean isTraceEnabled() {
   return log.isTraceEnabled();
 }

 @Override
 public void error(String s, Throwable e) {
   log.log(FQCN, Level.ERROR, s, e);
 }

 @Override
 public void error(String s) {
   log.log(FQCN, Level.ERROR, s, null);
 }

 @Override
 public void debug(String s) {
   log.log(FQCN, Level.DEBUG, s, null);
 }

 @Override
 public void trace(String s) {
   log.log(FQCN, Level.TRACE, s, null);
 }

 @Override
 public void warn(String s) {
   log.log(FQCN, Level.WARN, s, null);
 }

}

```

这里就运用了适配模式的对象适配器模式。