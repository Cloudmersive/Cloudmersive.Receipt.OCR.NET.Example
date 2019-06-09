# Cloudmersive.APIClient.NET.Validate.Model.FullEmailValidationResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ValidAddress** | **bool?** | True if the email address is valid overall, false otherwise | [optional] 
**MailServerUsedForValidation** | **string** | Email server connected to for verification | [optional] 
**ValidSyntax** | **bool?** | True if the syntax of the email address is valid, false otherwise.  This is one component of ValidAddress, but not the only one. | [optional] 
**ValidDomain** | **bool?** | True if the domain name of the email address is valid, false otherwise.  This is one component of ValidAddress, but not the only one. | [optional] 
**ValidSMTP** | **bool?** | True if the email address was verified by the remote server, false otherwise.  This is one component of ValidAddress, but not the only one. | [optional] 
**IsCatchallDomain** | **bool?** | True if the domain is a catch-all domain name, false otherwise.  Catch-all domain names, while rare, always accept inbound email to ensure they do not lose any potentially useful emails.  Catch-all domain names can occassionally be configured to first accept and store all inbound email, but then later send a bounce email back to the sender after a delayed period of time. | [optional] 
**Domain** | **string** | Domain name of the email address | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

