# Introduction #

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
![http://freebsd-texlive.googlecode.com/svn/branches/doc/images/distfile-types.png](http://freebsd-texlive.googlecode.com/svn/branches/doc/images/distfile-types.png)

As an example, the `svninfo` _Package_ is part of the `collection-latexextra` _Collection_, which is part of both `scheme-full` and `scheme-gutenberg` _Schemes_.

## Distfiles Grouping ##

Most (but not all) _Packages_, _Documentation_ and _TLCore_ distfiles can be grouped. For example:

  * `svninfo.doc.tar.lzma` — _Documentation_ of the package;
  * `svninfo.source.tar.lzma` — _Source_ of the package;
  * `svninfo.tar.lzma` — _Macros_ of the package.