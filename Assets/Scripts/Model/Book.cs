
using System;
using System.Collections.Generic;
/********************************************************************************

** Class name: Book

** Description: Load animal 3D modle to book

** Author: Ting Zhang

** Created: 2021-8-19

*********************************************************************************/
namespace QFramework
{
    

   
    [Serializable]
    public class Book
    {
        public string BookName;
        public List<Animal> Animals;
    }
    [Serializable]
    public class Animal
    {
        public string aniName;
        public ETrackAbleType trackAbleType;
        public string infoName;
        public string infoData;
        
    }

}