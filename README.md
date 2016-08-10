# Individual TeXLive ports for FreeBSD

The FreeBSD-TeXLive project provides [TeXLive](http://www.texlive.org) through individual ports in the [FreeBSD](http://www.FreeBSD.org) [ports collection](http://www.freshports.org).

**Thanks to Hiroki Sato (@hrs), TeXLive is now available as a few big ports in the FreeBSD ports tree, which should be the preffered way of installing TeXLive on FreeBSD for most users.  This repo is only maintained for the few who need more control on what is happening.**

* [Introduction](#introduction)
* [Installing](#installing)
* [Updating](#upgrading)

## Introduction

There are two main branches:

* `master`, where the basic infrastructure stands;
* `releng`, where the magic happen.

## Installing

### Adding TeXLive ports to your FreeBSD ports tree

There are basically two ways for having the TeXLive ports in your FreeBSD ports tree:

* Fetch already generated ports using portshaker;
* Generate the ports yourself.
   
#### Fetching already generated ports (recommended)

FreeBSD ports for all TeXLive packages are located in the releng branch of the repository. Install it using portshaker:

~~~
shell> make -C /usr/ports/ports-mgmt/portshaker-config install # Ensure TEXLIVE is checked
shell> portshaker -v
~~~

The ports are updated daily.

#### Generate the ports yourself (NOT recommended)

~~~
shell> mkdir freebsd-texlive
shell> cd freebsd-texlive
shell> git clone https://github.com/smortex/freebsd-texlive trunk
shell> ln -s trunk/Tools/texlive Makefile
shell> $EDITOR Makefile # Tweak to fit your needs
shell> make
~~~

You should update your ports quite often since TeXLive tarballs are updated daily. A crontab will hopefully do it for you while you sleep

### What next?

you will have a bunch of TeXLive ports in print/texlive-*foo*. You will need texlive-core which installs the binaries. The texlive-scheme-*foo* and texlive-collection-*foo* ports can help you install large collections of ports if you don't want to pin only the packages you use.


## Updating

The FreeBSD TeXLive repository is automatically updated each night at 4.30am UTC. The process is generaly less than one hour long, so the repository is generaly updated before 5.30 UTC.

Run `portshaker` without argument to update and merge to your local Ports Tree both FreeBSD official ports and FreeBSD TeXLive ports:

~~~
shell> portshaker
~~~

Then update your ports the usual way, for example using `portmaster` or `portupgrade`.

-----

# Introduction #

**This content was migrated from github and describe the situation at the early beginning of the project.  Some details have changed, but the general idea is supposed to be the same.  Informational only!**

The TeXLive Project provide `.tar.lzma` distfiles. `Mk/bsd.command.mk` and `Mk.bsd.ports.mk` have been updated so that the FreeBSD port system can handle them ([r3](https://code.google.com/p/freebsd-texlive/source/detail?r=3)).

While the TeXLive packages include binary packages for FreeBSD, FreeBSD-TeXLive prefer to compile from source

# Binaries Source Code #

The source code of all binaries is included in a single (big) archive: texlive-20080816-source.tar.lzma (22 Mb).

Installing this package is not enough to have a working TeXLive: binaries will need at least core macros and fonts to be suitable for any usage.

# Collections of Macro, Fonts, Documentation #

Although all binaries source code is provided in a single distfile, all the rest of TeXLive is split 5229 distfiles.

## Distfiles Content ##

TeXLive distfile are quite comparable to _regular_ software packages: they contains both data and metadata. Since TeXLive include an installer, there are packages containing this one and the metadata related to it. In the case of the port to FreeBSD, we will consider this installer as some kind of metadata: the TeXLive installation will he handled by the FreeBSD ports system (so that other ports can depend on TeXLive), thus the TeXLive installer will not be installed.

### Metadata ###

Metadata is used by the TeXLive installer to handle the TeXLive installation on the user system. As written before, we do not use the TeXLive installer for handle the setup on the machine, but rather the ports infrastructure.

Metadata is however used to create TeXLive ports.

Basically, metadata is stored in the `tlpkg/tlpobj/<package>.tlobj` directory of each distfile. As a consequence, for gathering information about the `svninfo.tar.lzma` package, extract and read `tlpkg/tlpobj/svninfo.tlpobj`:

```
name svninfo
category Package
revision 10233
runfiles size=5
 texmf-dist/tex/latex/svninfo/svninfo.cfg
 texmf-dist/tex/latex/svninfo/svninfo.sty
```

### Data ###

Package data is basically everything in the distfile except the contents of the `tlpkg` directory.

As written before, this directory has a `tlpobj` sub-directory that contains metadata information. The other files and directories that can be found in `/tlpkg` are relative to the TeXLive installer and should not be installed.

## Categories ##

Distfiles are split in 5 categories:
  * _Scheme_ (10 distfiles)
  * _Collection_ (84 distfiles)
  * _Packages_ (3618 distfiles)
  * _Documentation_ (207 distfiles)
  * _TLCore_ (1310 distfiles)

The relationships between these categories is represented bellow:
![https://raw.githubusercontent.com/smortex/freebsd-texlive/doc/images/distfile-types.png](https://raw.githubusercontent.com/smortex/freebsd-texlive/doc/images/distfile-types.png)

As an example, the `svninfo` _Package_ is part of the `collection-latexextra` _Collection_, which is part of both `scheme-full` and `scheme-gutenberg` _Schemes_.

## Distfiles Grouping ##

Most (but not all) _Packages_, _Documentation_ and _TLCore_ distfiles can be grouped. For example:

  * `svninfo.doc.tar.lzma` — _Documentation_ of the package;
  * `svninfo.source.tar.lzma` — _Source_ of the package;
  * `svninfo.tar.lzma` — _Macros_ of the package.
