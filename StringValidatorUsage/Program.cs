using StringUtilities;

Console.WriteLine("StringValidator usage example");

string?[] passwords = {
	null,
	"",
	" ",
	"	",
	"123", // too short
	"Ab12345!Ab12345!Ab12345!", // too long
	"12345",
	"1234@",
	"A12345%",
	"Ab12 345^",
	"Ab12	345^",
	"Ab12\n345^",
	"Ab12345!",
	"Ab12345\"",
	"Ab12345#",
	"Ab12345$",
	"Ab12345%",
	"Ab12345&",
	"Ab12345'",
	"Ab12345(",
	"Ab12345)",
	"Ab12345*",
	"Ab12345+",
	"Ab12345,",
	"Ab12345-",
	"Ab12345.",
	"Ab12345/",
	"Ab12345:",
	"Ab12345;",
	"Ab12345<",
	"Ab12345=",
	"Ab12345>",
	"Ab12345?",
	"Ab12345@",
	"Ab12345[",
	"Ab12345\\",
	"Ab12345]",
	"Ab12345^",
	"Ab12345_",
	"Ab12345`",
	"Ab12345{",
	"Ab12345|",
	"Ab12345}",
	"Ab12345~",
};

foreach (var password in passwords)
{
    Console.WriteLine($"Password: {password}. Is valid: {StringValidator.ValidatePassword(password)}");
}

Console.ReadLine();
