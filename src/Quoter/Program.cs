﻿using System;
using Microsoft.CodeAnalysis.CSharp;

namespace QuoterHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceText = "class C{}";
            var sourceNode = CSharpSyntaxTree.ParseText(sourceText).GetRoot() as CSharpSyntaxNode;
            var quoter = new Quoter
            {
                OpenParenthesisOnNewLine = false,
                ClosingParenthesisOnNewLine = false,
                UseDefaultFormatting = true
            };

            var generatedCode = quoter.Quote(sourceNode);

            var code = quoter.Evaluate(generatedCode);

            Console.WriteLine(generatedCode);
        }
    }
}
