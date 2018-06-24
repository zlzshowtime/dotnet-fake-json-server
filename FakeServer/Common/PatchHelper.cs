using System;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace FakeServer.Common
{
    //Provides JsonPatch opertability. Each OP function adds to the Operation Queue, and commits all 
    //when applyPatch()
    public class PatchHelper()
    {

        string file = null;

        static void addOP(string id, string value)
        {

        }
        static void removeOP(string id, string value)
    {

    }
        static void updateOP(string id, string value)
    {

        }
        static void deleteOP(string id, string value)
    {

        }
        static void applyPatch(string id, string value)
    {


        }

    }   
 
}