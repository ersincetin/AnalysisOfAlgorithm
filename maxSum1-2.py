#!/usr/bin/python 
2 # -*- coding: utf-8 -*- 
3 
 
4 import random 
5 #import timeit 
6 
 
7 def maxSubSum2(array): 
8     maxSum1=0 
9     for i in range(0,len(array)): 
10         thisSum1=0 
11         for j in range(i,len(array)): 
12             thisSum1=thisSum1+array[j] 
13             if(thisSum1>maxSum1): 
14                 maxSum1=thisSum1 
15     return maxSum1 
16 
 
17 def maxSubSum1(array): 
18     maxSum=0 
19     for i in range(0,len(array)): 
20         for j in range(i,len(array)): 
21             thisSum=0 
22             for k in range(i,j): 
23                 thisSum=thisSum+array[k] 
24             if(thisSum>maxSum): 
25                 maxSum=thisSum 
26     return maxSum 
27 
 
28 array=[4,-3,5,-2,-1,2,6,-2] 
29 size=int(input("dizinin boyutu ne olsun")) 
30 array1=[] 
31 for i in range(0,size): 
32     array1.append(random.randint(-20,20)) 
33      
34 print("dizinin boyutu : ",len(array1)) 
35 print("diznin elemanlarý : ") 
36 for i in range(0,size): 
37     print(i,".   ",array1[i]) 
38      
39 import time 
40 start_time=time.time() 
41 print("maxSubSum1 sonucu :", maxSubSum1(array1)) 
42 print("gecen süre : ", time.time()-start_time) 
43 print("maxSubSum2 sonucu :", maxSubSum2(array1)) 
44 print("gecen süre : ", time.time()-start_time) 
