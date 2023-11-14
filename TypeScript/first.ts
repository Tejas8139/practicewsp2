console.log("Welsome to Typescript")

function AddShipping(price:number, shipping: number)
{
    console.log(price+shipping);
}
AddShipping(10,20);

function AddShipping1(price:number, shipping: number):number
{
    return (price+shipping);
}
AddShipping(10,20);