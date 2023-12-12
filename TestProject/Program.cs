Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
if (daysUntilExpiration ==0){
    Console.WriteLine("Your suscription has expired.");
}
else if (daysUntilExpiration ==1){
    Console.WriteLine("Your suscription expires within a day.");
    Console.WriteLine("Renew now and save 20%!");
}
else if (daysUntilExpiration <=5){
    Console.WriteLine($"Your suscription expires in {daysUntilExpiration} days.");
    Console.WriteLine("Renew now and save 10%!");
}
else if (daysUntilExpiration <=10){
    Console.WriteLine("Your suscription will expire soon. Renew now!");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}