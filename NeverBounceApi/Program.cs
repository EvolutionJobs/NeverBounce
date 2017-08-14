﻿// Author: Mike Mollick <mike@neverbounce.com>
//
// Copyright (c) 2017 NeverBounce
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using NeverBounce;
using NeverBounceSdkExamples.Requests;

namespace NeverBounceSdkExamples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sdk = new NeverBounceSdk("api_key");

            var response = AccountEndpoint.Info(sdk);
            //var response = POEEndpoints.Confirm(sdk);
            //var response = SingleEndpoints.Check(sdk);
            //var response = JobsEndpoint.Search(sdk);
            //var response = JobsEndpoint.CreateSuppliedData(sdk);
            //var response = JobsEndpoint.CreateRemoteUrl(sdk);
            //var response = JobsEndpoint.Parse(sdk);
            //var response = JobsEndpoint.Start(sdk);
            //var response = JobsEndpoint.Status(sdk);
            //var response = JobsEndpoint.Results(sdk);
            //var response = JobsEndpoint.Download(sdk);
            //var response = JobsEndpoint.Delete(sdk);

            var_dump(response);
            Console.ReadLine();
        }

        public static void var_dump(object obj)
        {
            Console.WriteLine("{0,-18} {1}", "Name", "Value");
            var ln = @"-------------------------------------   
               ----------------------------";
            Console.WriteLine(ln);

            var t = obj.GetType();
            var props = t.GetProperties();

            for (var i = 0; i < props.Length; i++)
                try
                {
                    Console.WriteLine("{0,-18} {1}",
                        props[i].Name, props[i].GetValue(obj, null));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            Console.WriteLine();
        }
    }
}