﻿using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LinqToWiki.Collections;
// <copyright file="DictionaryDictionaryTKey1TKey2TValueTest.TryGetValue.g.cs">Copyright ©  2011</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace LinqToWiki.Collections.Tests
{
    public partial class DictionaryDictionaryTKey1TKey2TValueTest
    {

[TestMethod]
[PexGeneratedBy(typeof(DictionaryDictionaryTKey1TKey2TValueTest))]
public void TryGetValue174()
{
    DictionaryDictionary<int, int, int> dictionaryDictionary;
    bool b;
    Tuple<int, int, int>[] tuples = new Tuple<int, int, int>[0];
    dictionaryDictionary =
      DictionaryDictionaryFactory.Create((IEnumerable<Tuple<int, int, int>>)tuples);
    int i = 0;
    b = this.TryGetValue<int, int, int>(dictionaryDictionary, 0, 0, out i);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)dictionaryDictionary);
    Assert.IsNotNull
        (((Dictionary<int, Dictionary<int, int>>)dictionaryDictionary).Comparer);
    Assert.AreEqual<int>
        (0, ((Dictionary<int, Dictionary<int, int>>)dictionaryDictionary).Count);
    Assert.AreEqual<int>(0, i);
}

[TestMethod]
[PexGeneratedBy(typeof(DictionaryDictionaryTKey1TKey2TValueTest))]
public void TryGetValue947()
{
    DictionaryDictionary<int, int, int> dictionaryDictionary;
    bool b;
    Tuple<int, int, int>[] tuples = new Tuple<int, int, int>[1];
    Tuple<int, int, int> s0 = new Tuple<int, int, int>(0, 0, 0);
    tuples[0] = s0;
    dictionaryDictionary =
      DictionaryDictionaryFactory.Create((IEnumerable<Tuple<int, int, int>>)tuples);
    int i = 0;
    b = this.TryGetValue<int, int, int>(dictionaryDictionary, 0, 0, out i);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)dictionaryDictionary);
    Assert.IsNotNull
        (((Dictionary<int, Dictionary<int, int>>)dictionaryDictionary).Comparer);
    Assert.AreEqual<int>
        (1, ((Dictionary<int, Dictionary<int, int>>)dictionaryDictionary).Count);
    Assert.AreEqual<int>(0, i);
}
    }
}