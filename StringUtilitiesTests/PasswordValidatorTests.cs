using StringUtilities;

namespace StringValidatorTests
{
	public class PasswordValidatorTests
	{
		[Theory]
		[InlineData(null, false)]
		[InlineData("", false)]
		[InlineData(" ", false)]
		[InlineData("	", false)]
		[InlineData("123", false)]
		[InlineData("Abc@", false)]
		[InlineData("Ab12345!Ab12345!Ab12345!", false)]
		[InlineData("12345", false)]
		[InlineData("1234@", false)]
		[InlineData("A12345%", false)]
		[InlineData("Ab12 345^", false)]
		[InlineData("Ab12	345^", false)]
		[InlineData("Ab12\n345^", false)]
		[InlineData("Ab1!", true)]
		[InlineData("Ab12345!", true)]
		[InlineData("Ab12345\"", true)]
		[InlineData("Ab12345#", true)]
		[InlineData("Ab12345$", true)]
		[InlineData("Ab12345%", true)]
		[InlineData("Ab12345&", true)]
		[InlineData("Ab12345'", true)]
		[InlineData("Ab12345(", true)]
		[InlineData("Ab12345)", true)]
		[InlineData("Ab12345*", true)]
		[InlineData("Ab12345+", true)]
		[InlineData("Ab12345,", true)]
		[InlineData("Ab12345-", true)]
		[InlineData("Ab12345.", true)]
		[InlineData("Ab12345/", true)]
		[InlineData("Ab12345:", true)]
		[InlineData("Ab12345;", true)]
		[InlineData("Ab12345<", true)]
		[InlineData("Ab12345=", true)]
		[InlineData("Ab12345>", true)]
		[InlineData("Ab12345?", true)]
		[InlineData("Ab12345@", true)]
		[InlineData("Ab12345[", true)]
		[InlineData("Ab12345\\", true)]
		[InlineData("Ab12345]", true)]
		[InlineData("Ab12345^", true)]
		[InlineData("Ab12345_", true)]
		[InlineData("Ab12345`", true)]
		[InlineData("Ab12345{", true)]
		[InlineData("Ab12345|", true)]
		[InlineData("Ab12345}", true)]
		[InlineData("Ab12345~", true)]
		public void ValidatePassword_ReturnsCorrectResult(string? input, bool expectetResult)
		{
			var result = PasswordValidator.Validate(input);

			Assert.Equal(expectetResult, result);
		}
	}
}