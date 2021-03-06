﻿using System.Collections.Generic;
using System.Linq;

namespace PlasticLang.Ast
{
    public static class ExpressionExtensions
    {
        public static T[] Union<T>(this T self, IEnumerable<T> rest) where T : IExpression
        {
            return Enumerable.Repeat(self, 1).Union(rest).ToArray();
        }
    }
}
