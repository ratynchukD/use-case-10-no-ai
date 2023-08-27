using System.Text.RegularExpressions;

namespace StringUtilities
{
	
	public static class PasswordValidator
	{
		private static Regex passwordRegex = new("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z])^[\\S]*$");

		/// <summary>
		/// Validates if a string contains at least one uppercase letter,
		/// one lowercase letter, one digit, and one special character. 
		/// It also validates if the string length is within the acceptable range.
		/// </summary>
		/// <param name="input">A string to be validated.</param>
		/// <param name="minLength">The minimum required length. Optional, the default is 4. If lower than 4, it gets overriden to 4.</param>
		/// <param name="maxLength">The maximum required length. Optional, the default is 12.</param>
		/// <returns>True if the input is a valid passowrd, or false if it is not.</returns>
		public static bool Validate(string? input, int minLength = 4, int maxLength = 12)
		{
            if (minLength < 4)
            {
				minLength = 4;
			}

            if (!string.IsNullOrWhiteSpace(input) 
				&& input.Length >= minLength 
				&& input.Length <= maxLength)
			{
				return passwordRegex.Match(input).Success;
			}			

			return false;
		}
	}
}