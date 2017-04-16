# Computer-Architecture

## 1、 CacheSim using C*#*

Using Visual Studio 2017。

（很丑，勿喷）

预取与Cache 分成指令Cache与数据Cache**未实现**。（分够了）

a.      能够设置 Cache 总的大小

b.      能够设置 Cache 块的大小

c.      能够设置Cache 的映射机制：直接映射、n-路组相联

d.      能够设置** **Cache 的替换策略：LRU、FIFO …

e.      能够设置 Cache 的写策略：写回法、写直达法

f.      能够设置写不命中的调块策略

f.      有友好的操作界面，如使用界面来配置 Cache

实验给出三个地址流文件，你可以使用此文件来测试你的程序，该文件每行的格式如下：

```
type address
```

其中 type 表示访存的类型：0 代表读数据、1 代表写数据、2 代表读指令；address 表示访存的地址。