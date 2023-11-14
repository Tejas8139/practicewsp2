console.log("Welsome to Typescript")

// function AddShipping(price:number, shipping: number)
// {
//     console.log(price+shipping);
// }
// AddShipping(10,20);

function AddShipping1(price:number, shipping: number):number|boolean
{
    if((price+shipping)==30)
    {
        return true;
    }
    return (price+shipping);
}
AddShipping1(90,20);