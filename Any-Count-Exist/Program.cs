using AnyCountExist;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

var config = ManualConfig.CreateMinimumViable()
    //.AddLogicalGroupRules(BenchmarkLogicalGroupRule.ByParams)
    //.AddColumn(RankColumn.Arabic)
    //.AddColumn(StatisticColumn.AllStatistics)
    ;

BenchmarkRunner.Run<PerformanceCheck>(config);
