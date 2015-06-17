# qcrypto
This project is to create a unix-style binary for performing some basic crypto operations on Windows. Other products, like openssl, are able to do all of this and more, but I've been looking for something that can just run without any depencies and with an easier syntax.

## Goals
First and foremost, I want a clean, strict naming convention for the commands that the application handles. This includes 

This will run on older environments, so I will be targeting older versions of .NET. Probably no earlier than 3.0.

This application will also be dependant on crypto capabilities already found in the OS, and not implementing them internally. 

I hope to make this cross platform as well in the future, which may require changing what langauge its written in.

## Commands
These are just an overview of how I think it will operate for now. I'll implement this, and if it's working well I'll keep the syntax as-is.

### Generate
  qcrypto --generate --type key --keytype symmetric --keyalg AES --keysize 256 --output example.key
  qcrypto --generate --type key --keytype symmetric --keyalg DES --keyopts triple --output example.key
  qcrypto --generate --type key --keytype symmetric --keyalg DES --keyopts twokeytriple --output example.key
  qcrypto --generate --type key --keytype symmetric --keyalg DES --keyopts double --output example.key
  qcrypto --generate --type key --keytype symmetric --keyalg DES --keyopts single --output example.key

  qcrypto --generate --type key --keytype asymmetric --keyalg RSA --keysize 2048 --output example.pub example.key
  qcrypto --generate --type key --keytype asymmetric --keyalg DES --keysize 4096 --output example.pub example.key

### Encrypt

  qcrypto --generate --type rng --length 4096 --output random.txt

### Decrypt

  qcrypto --encrypt --key example.key --keytype asymmetric --keyalg aes --target foo.docx --output foo.docx.enc
  qcrypto --decrypt --key example.key --keytype asymmetric --keyalg aes --target foo.docx.enc --output foo.docx


### Hash

  qcrypto --hash --algorithm SHA1 --target foo.docx --output foo.docx.hash
  qcrypto --hash --algorithm SHA256 --target foo.docs
  qcrypto --hash --algorithm MD5 --target "test"
