namespace BusinessCore
{
    public class Chassis
    {
        private int weight;
        private string material;

        public Chassis(int weight, string material)
        {
            this.weight = weight;
            this.material = material;
        }

        public int setWeight(int newWeight) => this.weight = newWeight;
        public string setMaterial(string newMaterial) => this.material = newMaterial;
        public string getMaterial() {
            return this.material;
        }
        public int getWeight()
        {
            return this.weight;
        }



    }
}
