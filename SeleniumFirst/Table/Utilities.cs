using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
   public  class Utilities
    {

       static  List<TableDataCollection> _tableDataCollections = new List<TableDataCollection>();


        public static void ReadTable(IWebElement table)
        {
            //Get all the columns from the table
            var columns = table.FindElements(By.TagName("th"));

            var rows = table.FindElements(By.TagName("tr"));

            //Create row index
            int rowIndex = 0;

            foreach (var row in rows)
            {

                int colIndex = 0;

                var colDatas = row.FindElements(By.TagName("td"));

                foreach (var colValue in colDatas)
                {

                    _tableDataCollections.Add(new TableDataCollection
                    {

                        RowNumber = rowIndex,
                        ColName = columns[colIndex].Text,
                        ColValue = colValue.Text

                    });

                    //move to the next column
                    colIndex++;
                }

                rowIndex++;

            }

        }

        public static string ReadCell(string columnName,int rowNumber)
        {

            var data = (from e in _tableDataCollections
                        where e.ColName == columnName && e.RowNumber == rowNumber
                        select e.ColValue
                        ).SingleOrDefault();

            return data;
        }
    }



    public class TableDataCollection
    {

        public int RowNumber { get; set; }
        public string ColName { get; set; }
        public string ColValue { get; set; }
    }

}
