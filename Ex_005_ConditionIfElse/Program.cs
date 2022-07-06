Console.Write(" Введите имы пользователя: ");
string username = Console.ReadLine();
if( username.ToLower() == "цаца" ) // в "" писать с маленькой буквы, и не ставть перед/после написания в ковычках пробел 
    {
        Console.WriteLine( " Здравствуй Цаца новый год! " );
    }   
    else
    {
        Console.Write( " Привет, " );
        Console.WriteLine( username );
    }