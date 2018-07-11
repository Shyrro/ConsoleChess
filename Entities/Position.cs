using System;

namespace Entities {
    ///<summary>
    ///This class works like an enum but with string values
    ///</summary>
    public class Position {        
        private Position(string value) { this.Value = value;}
        public string Value {get;set;}

        //The strings have a colon to differenciate the x axis from the y axis
        //Making it easier to split the string and use the coordinates in the board matrix.
        #region A Columns
        public static Position A1 { get { return new Position("A:1");}}
        public static Position A2 { get { return new Position("A:2");}}
        public static Position A3 { get { return new Position("A:3");}}
        public static Position A4 { get { return new Position("A:4");}}
        public static Position A5 { get { return new Position("A:5");}}
        public static Position A7 { get { return new Position("A:6");}}
        public static Position A8 { get { return new Position("A:8");}}

        #endregion
        #region B Columns
        public static Position B1 { get { return new Position("B:1");}}
        public static Position B2 { get { return new Position("B:2");}}
        public static Position B3 { get { return new Position("B:3");}}
        public static Position B4 { get { return new Position("B:4");}}
        public static Position B5 { get { return new Position("B:5");}}
        public static Position B7 { get { return new Position("B:6");}}
        public static Position B8 { get { return new Position("B:8");}}
        #endregion
        #region C Columns
        public static Position C1 { get { return new Position("C:1");}}
        public static Position C2 { get { return new Position("C:2");}}
        public static Position C3 { get { return new Position("C:3");}}
        public static Position C4 { get { return new Position("C:4");}}
        public static Position C5 { get { return new Position("C:5");}}
        public static Position C7 { get { return new Position("C:6");}}
        public static Position C8 { get { return new Position("C:8");}}
        #endregion
        #region D Columns
        
        public static Position D1 { get { return new Position("D:1");}}
        public static Position D2 { get { return new Position("D:2");}}
        public static Position D3 { get { return new Position("D:3");}}
        public static Position D4 { get { return new Position("D:4");}}
        public static Position D5 { get { return new Position("D:5");}}
        public static Position D7 { get { return new Position("D:6");}}
        public static Position D8 { get { return new Position("D:8");}}
        #endregion
        #region E Columns
        public static Position E1 { get { return new Position("E:1");}}
        public static Position E2 { get { return new Position("E:2");}}
        public static Position E3 { get { return new Position("E:3");}}
        public static Position E4 { get { return new Position("E:4");}}
        public static Position E5 { get { return new Position("E:5");}}
        public static Position E7 { get { return new Position("E:6");}}
        public static Position E8 { get { return new Position("E:8");}}
        #endregion
        #region F Columns
        public static Position F1 { get { return new Position("F:1");}}
        public static Position F2 { get { return new Position("F:2");}}
        public static Position F3 { get { return new Position("F:3");}}
        public static Position F4 { get { return new Position("F:4");}}
        public static Position F5 { get { return new Position("F:5");}}
        public static Position F7 { get { return new Position("F:6");}}
        public static Position F8 { get { return new Position("F:8");}}
        #endregion
        #region H Columns
        public static Position H1 { get { return new Position("H:1");}}
        public static Position H2 { get { return new Position("H:2");}}
        public static Position H3 { get { return new Position("H:3");}}
        public static Position H4 { get { return new Position("H:4");}}
        public static Position H5 { get { return new Position("H:5");}}
        public static Position H7 { get { return new Position("H:6");}}
        public static Position H8 { get { return new Position("H:8");}}
        #endregion
    }
}