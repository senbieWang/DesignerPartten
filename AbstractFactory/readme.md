﻿# Abstract Factory
意图：提供一个创建一系列相关或相互依赖对象的接口，而无需制定具体的类。
动机：考虑一个支持多种视感（ l o o k - a n d - f e e l）标准的用户界面工具包，例如 M o t i f和 Presentation Manager。不同的视感风格为诸如滚动条、窗口和按钮等用户界面“窗口组件” 定义不同的外观和行为。为保证视感风格标准间的可移植性，一个应用不应该为一个特定的 视感外观硬编码它的窗口组件。在整个应用中实例化特定视感风格的窗口组件类将使得以后 很难改变视感风格。 