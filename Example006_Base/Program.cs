﻿int a = 1;
int b = 13;
int c = 4;
int d = 8;
int e = 14;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
int result = max;
Console.WriteLine(result);
