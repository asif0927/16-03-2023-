using System.Text.RegularExpressions;
using static System.Net.WebRequestMethods;

string phonenumber = "+994506165049";
string pattern = @"^([+994]{4})([50|55|70|77|51]{2})([0-9]{7})
|([50|55|70|77|51]{2})([0-9]{7})$";
bool isMatch=Regex.IsMatch(phonenumber, pattern);
Console.WriteLine(isMatch);

/*Metn*/
string text = "Abad abcd asanf slshjadsnjsadnj bad.Abac dajhajabja afad skjsahkds adssannasnj abdc.";
Regex regex=new Regex(@"\b[aA][a-fA-F]*[dD]\b");
MatchCollection matches=regex.Matches(text);
Console.WriteLine(matches);
foreach(Match match in matches)
{
    Console.WriteLine(match+" ");
}

string link = "https://tap.az/authentications/new#login-by-phone";
string pattern2= @"/^((http|https):\/\/)([a-zA-Z0-9]+\.{1}+[a-z]{1,}){1,}([\w]+\/){1,}+[a-zA-Z0-9#-]{1,}$/";
bool isMatch2=Regex.IsMatch(link, pattern2);
Console.WriteLine(isMatch2);
