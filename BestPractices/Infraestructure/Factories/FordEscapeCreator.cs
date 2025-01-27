using Best_Practices.ModelBuilders;
using Best_Practices.Models;

namespace Best_Practices.Infraestructure.Factories
{
	public class FordEscapeCreator : CarFactory
	{
		public override Vehicle Create()
		{
			return new CarModelBuilder()
				.SetModel("Escape")
				.SetBrand("Ford")
				.SetColor("Red")
				.Build();
		}
	}
}
