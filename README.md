# Multi Contributor Pricing

A pricing module based on Azure functions and event grid communication.

_This is a technology demonstrator project to show the capabilities and costs involved in choosing this technology.  The data are not to be relied on as it will be generated with randomised errors_

## Price

A price is made of three components - a price time (here always expressed converted to UTC), a priced item unique identifier and a price in a specified currency.

## Price contributors

Prices may be contributed by public exchnages, by trades or by private provision (whisper prices).  The source and quality of the price need to be available to any downstream processors to decide what (if anything) they will do upon notification of the price.
