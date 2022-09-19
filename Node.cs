﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    class Node
    {
        public char Symbol { get; set; }
        public double Frequency { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public List<bool> Reverse(char symbol, List<bool> data)
        {
            if (Right == null && Left == null)
            {
                if (Symbol.Equals(this.Symbol))
                {
                    return data;
                }
                else return null;
            }
            else
            {
                List<bool> left = null;
                List<bool> right = null;
                if (Left != null)
                {
                    List<bool> leftPath = new List<bool>();
                    leftPath.AddRange(data);
                    leftPath.Add(false);
                    left = Left.Reverse(symbol, leftPath);
                }
                if (Right != null)
                {
                    List<bool> rightPath = new List<bool>();
                    rightPath.AddRange(data);
                    rightPath.Add(false);
                    right = Right.Reverse(symbol, rightPath);
                }
                if (left != null)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            }
            
        }
    }
}
