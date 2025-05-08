namespace MultiShop.Cargo.DtoLayer.Dtos.CargoOperationDto
{
    public class CreateCargoOperationDto
    {
        public string Barcode { get; set; }
        public string Description { get; set; }
        public DateTime OperationDate { get; set; }
    }
}
