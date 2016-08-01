
/*
*@File Name: Menu.cs
*@Author: Alex Nicholls
*@Student Number: 200287546
*@Site: Assignment2
*@Date: July 31, 2016
*@Description: This page retrieves the data from the database and formats it into a model.  
*/

namespace Comp2007_Assignment2_Nicholls.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menu
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }
        public string Picture { get; set; }
        public Nullable<int> Price { get; set; }
    }
}
