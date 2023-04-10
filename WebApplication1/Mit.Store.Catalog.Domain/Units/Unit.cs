using MongoDB.Bson;

namespace WebApplication1.Mit.Store.Catalog.Domain.Units
{
    public class MeasuringUnits
    {
        #region Constructor
        public MeasuringUnits(string title)
        {
            InvariantValidation(title);
            Id = ObjectId.GenerateNewId().ToString();
            GroupTitle = title;
        }


        #endregion Constructor

        #region Property

        public string Id { get; protected set; }
        public string GroupTitle { get; protected set; }
        public List<Unit> Units { get; protected set; }

        #endregion Property


        #region Method

        public void ChangeGroupTitle(string groupTitle)
        {
            InvariantValidation(groupTitle);
            GroupTitle = groupTitle;
        }
        private void InvariantValidation(string groupTitle)
        {
            if (string.IsNullOrEmpty(groupTitle))
            {
                // todo:Exception Duplicate
                new Exception("Duplicate");
            }
        }

        public void AddUnit(Unit unit)
        {
            if (unit == null) { }
            Units.Add(unit);
        }
        public void RemoveUnit(Unit unit)
        {
         Units.Remove(unit);
        }
        #endregion Method






    }
    public class Unit
    {
        #region Constructor
        public Unit(string title)
        {

            InvariantValidation(title);
            Id = ObjectId.GenerateNewId().ToString();
            Title = title;
            IsActive = true;
        }

        #endregion Constructor

        #region Property
        public string Id { get; protected set; }
        public string Title { get; protected set; }
        public bool IsActive { get; protected set; }
        #endregion Property


        #region Method

        public void ChangeTitle(string title)
        {
            InvariantValidation(title);
            Title = title;
        }

        public void Active()
        {
            IsActive = true;
        }

        public void DeActive()
        {
            IsActive = true;
        }


        private void InvariantValidation(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                // todo:Exception Duplicate
                new Exception("Duplicate");
            }
        }
        #endregion Method






    }


}
