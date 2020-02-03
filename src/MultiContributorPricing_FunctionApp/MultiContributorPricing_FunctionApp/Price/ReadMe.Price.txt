Price
=====

A price is comprised of three parts :- 
(1) a unique identifier of the priced item,
(2) a price effective date/time,
(3) a price amount 

The unique identifier may need to be mapped by the price contributor if the uinique identifiers that they use is different to 
the global library identifiers we use

The price effective date/time is converted to UTC 

The price amount is a decimal amount and an ISO currency code

In addition a contributor may indicate the type of price and the quality so that any downstream systems may filter out the notifications accordingly

