namespace BootCampEifel.Utils
{
    public class Cars
    {
        public Cars()
        {
        }

        public string Llanta(string color, int rodada)
        {
            return $"llanta rodada:{rodada}, color: {color}"; 
        }

        public void Llanta2(string color, int rodada)
        {
            
        }

        public string Chasis(string marca, int año)
        {
            return $"El chasis es de la marca: {marca}, y del año: {año}";
        }
    }
}
