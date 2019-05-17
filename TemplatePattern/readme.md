## 模板方法模式（类行为模式）
1、意图

定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。
TemplateMethod使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。

3、动机
考虑一个提供Application和Document类的应用框架。Application类负责打开一个已有的 以外部形式存储的文档，如一个文件。
一旦一个文档中的信息从该文件中读出后，它就由一 个Document对象表示。 

4、适用性
 

![模式类图](https://github.com/senbieWang/DesignerPartten/blob/master/TemplatePattern/Diagram/TemplateMethod.jpg)

