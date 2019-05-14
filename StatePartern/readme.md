## 状态模式（对象行为模式）
1、意图
允许一个对象在其内部状态改变时改变它的行为。对象看起来似乎修改了它的类（似乎变成了其他的类）。

2、别名
状态对象（Object for State）

3、动机
考虑一个表示网络连接的类TCPConnection。一个TCPConnection对象的状态处于若干不同状态之一: 连接已建立（Established）、正在监听(Listening)、连接已关闭(Closed)。
当一个TCPConnection对象收到其他对象的请求时 , 它根据自身的当前状态作出不同的反应。例如，一个Open请求的结果依赖于连接是处于已关闭状态还是已建立状态。

4、适用性
在下面的两种情况下均可使用State模式: 
• 一个对象的行为取决于它的状态, 并且它必须在运行时刻根据状态改变它的行为。 
• 一个操作中含有庞大的多分支的条件语句，且这些分支依赖于该对象的状态。
这个状 态通常用一个或多个枚举常量表示。通常 , 有多个操作包含这一相同的条件结构。 
State 模式将每一个条件分支放入一个独立的类中。这使得你可以根据对象自身的情况将对 
象的状态作为一个对象，这一对象可以不依赖于其他对象而独立变化。 


![模式类图](https://github.com/senbieWang/DesignerPartten/blob/master/StatePartern/Diagram/StatePattern.jpg)


![案例类图](https://github.com/senbieWang/DesignerPartten/blob/master/StatePartern/Diagram/TCPStateClass.jpg)
