## 观察者模式（对象行为模式）
1、意图
定义对象间的一种一对多的依赖关系，当一个对象的状态发生改变时，所有依赖于它的对象都会得到通知并自动更新。
让多个观察者对象同时监听某一个主题对象，当这个主题对象在状态发生变化时，会通知所有观察者对象，使他们能够自动更新自己。

2、别名
发布-订阅

3、动机
将一个系统分割成一系列相互协作的类有一个常见的副作用：需要维护相关对象间的一直性。我们不希望为了维护一致性而使各类紧密耦合，
因为这样降低了他们的可重用性。
案例： 统一数据来源的不同表现，当数据来源发生变化时，多种表现要一起更新。


![模式类图](https://github.com/senbieWang/DesignerPartten/blob/master/Observer/Diagram/ObserverClass.png)


![模式时序图](https://github.com/senbieWang/DesignerPartten/blob/master/Observer/Diagram/ObserverSeq.png)
