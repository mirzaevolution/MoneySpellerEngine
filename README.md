# MoneySpellerEngine

This lightweight library is used to spell out numbers in positive integer 64 bit into spelled out numbers from 1 to 999,999,999,999,999 (Trillion). Currently, it only supports ID (Indonesia) and EN (English) languages. 
We hope your contribution in your own language(s) using our core interface **ISpeller**. 

Here we will outline some tests that we performed: 

### Computer Specification:
* Processor          : Intel(R) Core(TM) i3-3240 @ 3.40 GHz (Turbo-Boost)
* RAM                : 16.0 GB
* System type        : x64 based processor
* OS                 : MS Windows 10 (10.0, Build 14393)


### Project Specification:
* .NET Version       : .NET Framework 4.0 
* Language           : C#
* Configuration      : Configuration was performed in RELEASE mode


### Static Test

This test used static sample 999,994,567,890,532 to generate its spelled numbers in both languages for 10,000,000 in 5 times and we calculated
total and average of all.

**Indonesian Run-Test**
* Single sample used       : 999,994,567,890,532
* Iteration                : 10,000,000 x 5 times
* Total elapsed            : 00:01:39.9259223
* Total elapsed in ms      : 99925 ms
* Avg elapsed in sec       : 19.985 sec
* Avg elapsed in ms        : 19985 ms

**English Run-Test**
* Single sample used       : 999,994,567,890,532
* Iteration                : 10,000,000 x 5 times
* Total elapsed            : 00:01:35.9875708
* Total elapsed in ms      : 95987 ms
* Avg elapsed in sec       : 19.197 sec
* Avg elapsed in ms        : 19197 ms


![Static Test](https://raw.githubusercontent.com/mirzaevolution/MoneySpellerEngine/master/MoneySpellerEngine.BenchmarkTest/STATIC_TEST_SCREENSHOT.PNG)


---------------------------------------




### Choosen Samples Test

This test used choosen samples (231 data) that we created against the most difficult spelling in real life (you can inspected the data @ our BenchmarkTest Project).

**Indonesian Run-Test**
* Total samples : 231
* Elapsed       : 00:00:00.0060646

**English Run-Test**
* Total samples : 231
* Elapsed       : 00:00:00.0045587

![Choosen samples EN](https://raw.githubusercontent.com/mirzaevolution/MoneySpellerEngine/master/MoneySpellerEngine.BenchmarkTest/CHOOSEN_SAMPLES_TEST_SCREENSHOT_EN_1.PNG)


![Choosen samples ID](https://raw.githubusercontent.com/mirzaevolution/MoneySpellerEngine/master/MoneySpellerEngine.BenchmarkTest/CHOOSEN_SAMPLES_TEST_SCREENSHOT_ID_1.PNG)


![Choosen samples Final](https://raw.githubusercontent.com/mirzaevolution/MoneySpellerEngine/master/MoneySpellerEngine.BenchmarkTest/CHOOSEN_SAMPLES_TEST_SCREENSHOT_ID_EN_FINAL.PNG)


---------------------------------------




### Dynamic Test Against 1 - 1,000,000,000 Iteration

This is the most difficult test that we performed. It basically generated spelled out numbers in 1 - 1,000,000,000 iterations in both languages.
Because the limitation of our computer, we just only set the iteration until 1,000,000,000. 

**Indonesian Run-Test**
* Iteration                : 1,000,000,000
* Total elapsed            : 00:16:53.8371805
* Total elapsed in ms      : 1013837 ms

**English Run-Test**
* Iteration                : 1,000,000,000
* Total elapsed            : 00:15:57.7548077
* Total elapsed in ms      : 957754 ms
---------------------------------------


Test performed: October 9, 2017

License: [MIT License](https://github.com/mirzaevolution/MoneySpellerEngine/blob/master/LICENSE)

### Instal from [Nuget.org](https://www.nuget.org/packages/MoneySpellerEngine/1.1.0)
```
Install-Package MoneySpellerEngine -Version 1.1.0
```

Best Regards,


**Mirza Ghulam Rasyid**
