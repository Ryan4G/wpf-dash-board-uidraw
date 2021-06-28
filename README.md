# WPF-DashBoardUIDraw

#### 介绍
模仿后台DashBoard 界面效果，使用WPF 实现。

#### 软件说明

参考B站 BV1aE411i7YQ , 跟着UP主入门  WPF 项目。

实现：
1. 菜单模块显示
2. 阴影效果实现
3. 图表控件的引入和使用
4. 图表控件内地图的使用

没有按照UP主的步骤进行实现，但使用了UP主此前介绍的控件知识，根据自身理解实现：

1. 目录菜单使用重写 ListBox 进行实现，可进行点击切换选中
2. 选取了另一个模板进行实现，在项目 EffectPicture 中有原始效果图，和最终模仿的效果图
3. 图表控件使用了不同类型数据呈现
4. 重写ListView 实现表格显示
5. 引入地图控件，实现全球数据展示

> 引入的LiveChart 不兼容.NET5， 实际部分库会以 .NET Framework 4.6 运行

#### 原始效果图

![原始效果图1](https://gitee.com/ryan4gitee/wpf-dash-board-uidraw/blob/master/EffectPicture/Raw/Effect1.png)


![原始效果图2](https://gitee.com/ryan4gitee/wpf-dash-board-uidraw/blob/master/EffectPicture/Raw/Effect2.png)


![原始效果图3](https://gitee.com/ryan4gitee/wpf-dash-board-uidraw/blob/master/EffectPicture/Raw/Effect3.png)

#### 完成效果图

![完成效果图1](https://gitee.com/ryan4gitee/wpf-dash-board-uidraw/blob/master/EffectPicture/Complete/Effect1.png)


![完成效果图2](https://gitee.com/ryan4gitee/wpf-dash-board-uidraw/blob/master/EffectPicture/Complete/Effect2.png)

