# ������ģʽ

��һ����Ľӿ�ת���ɿͻ�ϣ��������һ���ӿڣ�ʹ��ԭ�����ڽӿڲ����ݶ�����һ��������Щ����һ������

�����������е����Ӿ��Ǳ�ѹ���������220v��ѹת��Ϊ�ֻ��ܽ��ܵ�5v��ѹ�������ǽ�����ת��Ϊ���ղ�ͷ�ȵȡ�

## �ṹ

* Ŀ��ӿڣ�ITarget������ǰϵͳҵ�����ڴ��Ľӿڣ��������ǳ������ӿ�
* �������ߣ�Adaptee���ࣺ���Ǳ����ʺ�������ִ�������е�����ӿ�
* ��������Adapter���ࣺ����һ��ת������ͨ���̳л����������ߵĶ��󣬰������߽ӿ�ת����Ŀ��ӿڣ��ÿͻ���Ŀ��ӿڵĸ�ʽ����������

## ��������

������ʵ��Ŀ��ӿڣ�ͬʱҲ�̳б������ߡ�

����������Ϊʹ���˼̳У������Ϻϳɷ���ԭ��Ҳ�����ϵ�һְ��ԭ����ϴ����Բ�����ʹ�á�

## ����������

������ֻʵ��Ŀ��ӿڣ�Ȼ�󽫱������߾ۺϵ���һ����ע�뵽���������У����ڲ�ʹ�ñ������������ϵͳ����Ҫ�Ľӿڡ�

## ����

Sample�е����ӱȽϷ�����ʵ������ǲ����Ǻ�����ʵ�ʿ����ĳ������������ʵ�����������������ӣ�

��Mybatsi��logging���У���һ��Log�ӿڣ�

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

�ýӿڶ�����Mybatisֱ��ʹ�õ���־��������Log�ӿھ�����˭��ʵ���أ�Mybatis�ṩ�˶�����־��ܵ�ʵ�֣���Щʵ�ֶ�ƥ�����Log�ӿ�������Ľӿڷ���������ʵ���������ⲿ��־��ܵ�Mybatis��־�������䣺�������Log4jImpl��ʵ����˵����ʵ�ֳ�����org.apache.log4j.Logger��ʵ����Ȼ�����е���־��������ί�и�ʵ����ʵ�֡�public class Log4jImpl implements Log {

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

���������������ģʽ�Ķ���������ģʽ��