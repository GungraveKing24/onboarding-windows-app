## 🔍 Research & Learn
---
#### What is code signing and how does it secure applications?
Does the digital signature process serve to:
* Verify who the creator is
* Ensure that it hasn't been modified
* Prevent security alerts, for example, in Windows (SmartScreen)

#### How does Azure Code Sign with an EV certificate work, and why is it important for maintaining trust?
* Azure code sign the code where's on cloud
* Uses an EV (Extended Validation) certificate
    * Strictly verifies the developer's identity
    * Greater security for Windows and antivirus software
* Private keys remain within Azure, ensuring greater security.

#### What are the broader implications of the deployment process for application security and reliability?
Security Implications
* Prevents malware and tampering
* Reduces false positives
* Ensures reliable deployments
* Improves software reputation

## 📝 Reflection
---
#### Reflect on why code signing is a critical step in the deployment process.

With a signature: The user and the operating system trust signed apps.
Without a signature: Warnings, blocks, or uninstallation.

#### How does understanding the deployment process, even at a high level, impact your approach to development?
It forces you to think about security from the start, improving discipline in builds and releases and reducing errors in production.

#### What risks could arise if code signing is overlooked or improperly managed?

* Apps marked as insecure
* Risk of impersonation
* Loss of user trust
* Possible distribution of altered code

## 🛠️ Task
---
#### Research the basics of code signing, focusing on Azure Code Sign with an EV certificate.
Code signing guarantees the authenticity and integrity of the software.
Azure Code Sign with EV certificates improves operating system trust and protects private keys in the cloud.
Ignoring this process can lead to security alerts, loss of trust, and risks of code tampering during deployment.