namespace CarManufacturing.Components
{
    public class GearBox : IGearBox
    {
        private readonly short _numberOfGears;
        private readonly bool _isAutomatic;

        public GearBox(short numberOfGears, bool isAutomatic)
        {
            _numberOfGears = numberOfGears;
            _isAutomatic = isAutomatic;
        }
    }
}