namespace controlSistenCheck
{
    public class Detalle
    {
        public int No_Detalle { get; set; }
        public string Detalles { get; set; }

        public Detalle() { }
        public Detalle(int pId, string pDetalle)
        {
            this.No_Detalle = pId;
            this.Detalles = pDetalle;
        }
    }
}