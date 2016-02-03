# WCF-SECURITY-USING-Certificate

This code explains how to communicate the Client & Server using Certificate WITH WCF Services. 

To Create a Sample/dummy certificate use the MakeCert.exe from VS command prompt. 

To Create a Server Certificate
===================
makecert.exe -sr CurrentUser -ss My -a sha1 -n CN=WCfServer -sky exchange -pe

To Create a Client Certificate
=================================
makecert.exe -sr CurrentUser -ss My -a sha1 -n CN=WcfClient -sky exchange -pe

both the cerficates creates under the Currentuser cretentials 

 Copy the certificates in trusted people certificates
 ======================================================
Go to Start -> Run and type MMC and press Enter. You will be popped with the MMC console. Click on File -> Add/remove snap-in. You will be popped up with an Add/Remove snap-in, click on the Add button, select Certificates, and select ‘My user account’.

PeerTrust and Chain trust
==========================

Either mode specifies that the certificate can either be self-issued (peer trust) or part of a chain of trust. The CertificateValidationMode property also enables you to customize how certificates are authenticated. By default, the level is set to ChainTrust. 

Chain Trust
============

Certificates are created in a hierarchy where each individual certificate is linked to the CA that issued the certificate.
This link is to the CA’s certificate. The CA’s certificate then links to the CA that issued the orginal CA’s certificate. This process is repeated up until the Root CA’s certificate is reached.

The Root CA’s certificate is inherently trusted.
Digital certificates are used to authenticate an entity by relying this hierarchy, also called a chain of trust. You can view any certificate's chain using the MMC snap-in by double-clicking any certificate, then clicking the Certificate Path tab.
