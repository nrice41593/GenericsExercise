﻿using System;
using System.Collections.Generic;

namespace GenericsExercise
{
    public class DictionaryExercise
    {
        public static Dictionary<int, List<string>> GetEmployeesByAge(List<Employee> employees)
        {
            var result = new Dictionary<int, List<string>>();

            foreach (var e in employees)
            {
                if (result.ContainsKey(e.Age))
                {
                    result[e.Age].Add(e.Name);
                }
                else
                {
                    result.Add(e.Age, new List<string>()
                    { e.Name });
                }

            }
            return result;
        }
    }
}
