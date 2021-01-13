## How to run locally

This sample includes  server implementations in Node

Follow the steps below to run locally.

**1. Clone and configure the sample**

**Installing and cloning manually**

```
git clone https://github.com/stripe-samples/checkout-single-subscription
```

Copy the `.env.example` file into a file named `.env` in the folder of the server you want to use. For example:

```
cp .env.example server/node/.env
```

You will need a Stripe account in order to run the demo. Once you set up your account, go to the Stripe [developer dashboard](https://stripe.com/docs/development/quickstart#api-keys) to find your API keys.

```
STRIPE_PUBLISHABLE_KEY=<replace-with-your-publishable-key>
STRIPE_SECRET_KEY=<replace-with-your-secret-key>
```

**2. Create Products and Prices on Stripe**

This sample requires two [Price](https://stripe.com/docs/api/prices/object) IDs to create the Checkout page. Products and Prices are objects on Stripe that let you model a subscription.

**Using the Dashboard**

You can create Products and Prices [in the dashboard](https://dashboard.stripe.com/products). Create two recurring Prices to run this sample.

**Update BASIC_PRICE_ID and PRO_PRICE_ID in your .env file**

Repeat these steps for to create a second product and price.

Next, open `.env` in the folder of the server you want to use, and update the values for `BASIC_PRICE_ID` and  `PRO_PRICE_ID` with the price IDs of the two prices you added.

**3. Confirm that you have set the account name**

In order to use Checkout, you must set an account or business name at https://dashboard.stripe.com/account

**4. Follow the server instructions on how to run:**

Pick the server language you want and follow the instructions in the server folder README on how to run.

For example, if you want to run the Node server:

```
cd server/node # there's a README in this folder with instructions
npm install
npm start
```

**[Optional] Customize your branding**

To customize your icon, logo and colors for Checkout and the Customer Portal, go to [Branding settings](https://dashboard.stripe.com/account/branding) in the Dashboard.
