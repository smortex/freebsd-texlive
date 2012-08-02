# New ports collection makefile for:	texlive-collection-binextra
# Date created:		13/03/2010 04:24:51
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	collection-binextra
PORTVERSION=	20120714
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	TeX auxiliary programs

RUN_DEPENDS=	${LOCALBASE}/share/texmf/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/base/xampl.bib:${PORTSDIR}/print/texlive-bibtex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cm/cmtext-bsr-interpolated.map:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf/dvipdfm/config/config:${PORTSDIR}/print/texlive-dvipdfm \
		${LOCALBASE}/share/texmf/dvipdfmx/dvipdfmx.cfg:${PORTSDIR}/print/texlive-dvipdfmx \
		${LOCALBASE}/share/texmf-dist/tex/latex/dvipdfmx-def/dvipdfmx.def:${PORTSDIR}/print/texlive-dvipdfmx-def \
		${LOCALBASE}/share/texmf-dist/dvips/base/ehandler.ps:${PORTSDIR}/print/texlive-dvips \
		${LOCALBASE}/share/texmf-dist/tex/generic/enctex/1250-csf.tex:${PORTSDIR}/print/texlive-enctex \
		${LOCALBASE}/share/texmf-dist/tex/plain/etex/etex.src:${PORTSDIR}/print/texlive-etex \
		${LOCALBASE}/share/texmf-dist/tex/latex/etex-pkg/etex.sty:${PORTSDIR}/print/texlive-etex-pkg \
		${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/share/texmf/dvips/gsftopk/render.ps:${PORTSDIR}/print/texlive-gsftopk \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/oberdiek/ifluatex.sty:${PORTSDIR}/print/texlive-ifluatex \
		${LOCALBASE}/share/texmf-dist/tex/generic/ifxetex/ifxetex.sty:${PORTSDIR}/print/texlive-ifxetex \
		${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/scripts/lua-alt-getopt/alt_getopt.lua:${PORTSDIR}/print/texlive-lua-alt-getopt \
		${LOCALBASE}/share/texmf/tex/generic/config/luatex-unicode-letters.tex:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf-dist/makeindex/base/din.ist:${PORTSDIR}/print/texlive-makeindex \
		${LOCALBASE}/share/texmf-dist/metafont/base/expr.mf:${PORTSDIR}/print/texlive-metafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/mflogo/mflogo.sty:${PORTSDIR}/print/texlive-mflogo \
		${LOCALBASE}/share/texmf-dist/mft/base/README:${PORTSDIR}/print/texlive-mfware \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/misc/black.mf:${PORTSDIR}/print/texlive-misc \
		${LOCALBASE}/share/texmf/fonts/map/pdftex/updmap/pdftex.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf-dist/web2c/updmap.cfg:${PORTSDIR}/print/texlive-tetex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf/texconfig/README:${PORTSDIR}/print/texlive-texconfig \
		${LOCALBASE}/share/texmf/scripts/texlive/lua/texlive/getopt.tlu:${PORTSDIR}/print/texlive-texlive-scripts \
		${LOCALBASE}/share/texmf/scripts/texlive/tlmgr.pl:${PORTSDIR}/print/texlive-texlive.infra \
		${LOCALBASE}/share/texmf/xdvi/XDvi:${PORTSDIR}/print/texlive-xdvi \
		${LOCALBASE}/share/texmf/scripts/a2ping/a2ping.pl:${PORTSDIR}/print/texlive-a2ping \
		${LOCALBASE}/share/texmf/tex/latex/asymptote/asymptote.sty:${PORTSDIR}/print/texlive-asymptote \
		${LOCALBASE}/share/texmf-dist/bibtex/csf/base/88591lat.csf:${PORTSDIR}/print/texlive-bibtex8 \
		${LOCALBASE}/share/texmf-dist/scripts/bundledoc/arlatex:${PORTSDIR}/print/texlive-bundledoc \
		${LOCALBASE}/share/texmf/chktex/chktexrc:${PORTSDIR}/print/texlive-chktex \
		${LOCALBASE}/share/texmf-dist/scripts/ctanify/ctanify:${PORTSDIR}/print/texlive-ctanify \
		${LOCALBASE}/share/texmf-dist/scripts/ctanupload/ctanupload.pl:${PORTSDIR}/print/texlive-ctanupload \
		${LOCALBASE}/share/texmf-dist/tex/plain/cweb/cwebmac.tex:${PORTSDIR}/print/texlive-cweb \
		${LOCALBASE}/share/texmf-dist/scripts/de-macro/de-macro:${PORTSDIR}/print/texlive-de-macro \
		${LOCALBASE}/share/texmf/doc/man/man1/dt2dv.1:${PORTSDIR}/print/texlive-dtl \
		${LOCALBASE}/share/texmf/doc/man/man1/dvi2tty.1:${PORTSDIR}/print/texlive-dvi2tty \
		${LOCALBASE}/share/texmf-dist/scripts/dviasm/dviasm.py:${PORTSDIR}/print/texlive-dviasm \
		${LOCALBASE}/share/texmf/doc/man/man1/dvidvi.1:${PORTSDIR}/print/texlive-dvidvi \
		${LOCALBASE}/share/texmf-dist/scripts/findhyph/findhyph:${PORTSDIR}/print/texlive-findhyph \
		${LOCALBASE}/share/texmf-dist/scripts/fragmaster/fragmaster.pl:${PORTSDIR}/print/texlive-fragmaster \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyphenex/ushyphex.tex:${PORTSDIR}/print/texlive-hyphenex \
		${LOCALBASE}/share/texmf-dist/scripts/installfont/installfont-tl:${PORTSDIR}/print/texlive-installfont \
		${LOCALBASE}/share/texmf/doc/man/man1/lacheck.1:${PORTSDIR}/print/texlive-lacheck \
		${LOCALBASE}/share/texmf-dist/tex/latex/latex2man/latex2man.sty:${PORTSDIR}/print/texlive-latex2man \
		${LOCALBASE}/share/texmf-dist/scripts/latexdiff/latexdiff-vc.pl:${PORTSDIR}/print/texlive-latexdiff \
		${LOCALBASE}/share/texmf-dist/scripts/latexfileversion/latexfileversion:${PORTSDIR}/print/texlive-latexfileversion \
		${LOCALBASE}/share/texmf-dist/scripts/latexmk/latexmk.pl:${PORTSDIR}/print/texlive-latexmk \
		${LOCALBASE}/share/texmf-dist/scripts/latexpand/latexpand:${PORTSDIR}/print/texlive-latexpand \
		${LOCALBASE}/share/texmf-dist/tex/latex/listings-ext/listings-ext.sty:${PORTSDIR}/print/texlive-listings-ext \
		${LOCALBASE}/share/texmf-dist/scripts/match_parens/match_parens:${PORTSDIR}/print/texlive-match_parens \
		${LOCALBASE}/share/texmf-dist/scripts/mkjobtexmf/mkjobtexmf.pl:${PORTSDIR}/print/texlive-mkjobtexmf \
		${LOCALBASE}/share/texmf-dist/scripts/pdfcrop/pdfcrop.pl:${PORTSDIR}/print/texlive-pdfcrop \
		${LOCALBASE}/share/texmf-dist/scripts/pdfjam/pdf180:${PORTSDIR}/print/texlive-pdfjam \
		${LOCALBASE}/share/texmf/scripts/tetex/e2pall.pl:${PORTSDIR}/print/texlive-pdftools \
		${LOCALBASE}/share/texmf-dist/scripts/pkfix/pkfix.pl:${PORTSDIR}/print/texlive-pkfix \
		${LOCALBASE}/share/texmf-dist/scripts/pkfix-helper/pkfix-helper:${PORTSDIR}/print/texlive-pkfix-helper \
		${LOCALBASE}/share/texmf-dist/scripts/purifyeps/purifyeps:${PORTSDIR}/print/texlive-purifyeps \
		${LOCALBASE}/share/texmf/doc/man/man1/dvibook.1:${PORTSDIR}/print/texlive-seetexk \
		${LOCALBASE}/share/texmf-dist/scripts/sty2dtx/sty2dtx.pl:${PORTSDIR}/print/texlive-sty2dtx \
		${LOCALBASE}/share/texmf-dist/scripts/texcount/texcount.pl:${PORTSDIR}/print/texlive-texcount \
		${LOCALBASE}/share/texmf-dist/scripts/texdef/texdef.pl:${PORTSDIR}/print/texlive-texdef \
		${LOCALBASE}/share/texmf-dist/scripts/texdiff/texdiff:${PORTSDIR}/print/texlive-texdiff \
		${LOCALBASE}/share/texmf-dist/scripts/texdirflatten/texdirflatten:${PORTSDIR}/print/texlive-texdirflatten \
		${LOCALBASE}/share/texmf-dist/texdoc/texdoc.cnf:${PORTSDIR}/print/texlive-texdoc \
		${LOCALBASE}/share/texmf-dist/scripts/texliveonfly/texliveonfly.py:${PORTSDIR}/print/texlive-texliveonfly \
		${LOCALBASE}/share/texmf-dist/scripts/texloganalyser/texloganalyser:${PORTSDIR}/print/texlive-texloganalyser \
		${LOCALBASE}/share/texmf-dist/scripts/typeoutfileinfo/typeoutfileinfo.sh:${PORTSDIR}/print/texlive-typeoutfileinfo \
		${LOCALBASE}/share/texmf/scripts/xindy/texindy.pl:${PORTSDIR}/print/texlive-xindy

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
