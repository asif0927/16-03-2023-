/*Nomre taski */
var phonenumber=+994506165049;
var pattern=/^([+994]{4})([50|55|70|77|51]{2})([0-9]{7})|([50|55|70|77|51]{2})([0-9]{7})$/gi;
var isMatch=pattern.test(phonenumber);
console.log(isMatch);
/*Link secmek */
var link="https://tap.az/authentications/new#login-by-phone";
var pattern2=/^((http|https):\/\/)([a-zA-Z0-9]+\.{1}+[a-z]{1,}){1,}([\w]+\/){1,}+[a-zA-Z0-9#-]{1,}$/gi;
var isMatch2=pattern2.test(link);
console.log(isMatch2);
/* Metn secmek*/
var text="Abad abcd asanf slshjadsnjsadnj bad.Abac dajhajabja skjsahkds adssannasnj abdc.";
var pattern3=/\b[aA][a-fA-F]*[dD]\b/gi;
var matches=text.match(pattern3);
matches.forEach(element => {
    console.log(element);
});

