using System;
using System.Reflection;
using Entities;
using Enums;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int width = 6; // the number of cells on the X axis
            int height = 2; // the number of cells on the Y axis
            bool[,] allNodes = new bool[height-1,width-1];
            for (int i = 0; i < height -1; i++)
            {
                string line = "0.0.0"; // width characters, each either 0 or .
                for(int j=0; j<width-1;j++) {
                    if(line[j] != '.') {                       
                        allNodes[i,j] = true;
                    }else {
                        allNodes[i,j] = false;   
                    }                    
                }
            }
            for(int i=0;i<height-1;i++){
                for(int j=0;j<width-1;j++){
                    if(allNodes[i,j]){
                    
                    var k = j+1;
                    var right = "-1 -1";
                    var rightFound = false;
                    while(!rightFound && k<width-1) {
                        if(allNodes[i,k]){
                            right = $"{k} {i}";   
                            rightFound = true;
                        }else{
                            k++;   
                        }                                                
                    } 
                    
                    var b = i+1;
                    var bottom = "-1 -1";
                    var bottomFound = false;
                    while(!bottomFound && b<height-1) {
                        if(allNodes[b,j]){
                            bottom = $"{j} {b}";   
                            bottomFound = true;
                        }else{
                            b++;   
                        }                                                
                    } 
                    Console.WriteLine("{0} {1} {2} {3}",j,i,right,bottom);
                }
                }                
            }
        }
    }
}
