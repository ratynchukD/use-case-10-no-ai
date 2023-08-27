using System.Text.RegularExpressions;

namespace StringUtilities
{
	
	public static class StringValidator
	{
		private static Regex passwordRegex = new("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z])^[\\S]*$");

		/// <summary>
		/// Validates if a string contains at least one uppercase letter,
		/// one lowercase letter, one digit, and one special character. 
		/// It also validates if the string length is within the acceptable range.
		/// </summary>
		/// <param name="input">A string to be validated.</param>
		/// <param name="minLength">The minimum required length.</param>
		/// <param name="maxLength">The maximum required length.</param>
		/// <returns></returns>
		public static bool ValidatePassword(string? input, int minLength = 4, int maxLength = 12)
		{
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