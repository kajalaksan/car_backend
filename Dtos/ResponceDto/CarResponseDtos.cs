namespace CarEndals.Dtos.ResponceDto
{
    public class CarResponseDtos
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CarModel { get; set; }
        public string FuelType { get; set; }
        public string CarNo { get; set; }
        public string ReleasDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
