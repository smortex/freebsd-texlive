# New ports collection makefile for:	texlive-collection-langgreek
# Date created:		13/03/2010 04:36:58
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	collection-langgreek
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	Greek

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/betababel/betababel.sty:${PORTSDIR}/print/texlive-betababel \
		${LOCALBASE}/share/texmf-dist/tex/latex/bgreek/bgreek.sty:${PORTSDIR}/print/texlive-bgreek \
		${LOCALBASE}/share/texmf-dist/fonts/enc/dvips/cbfonts/CB.enc:${PORTSDIR}/print/texlive-cbfonts \
		${LOCALBASE}/share/texmf-dist/tex/latex/gfsbaskerville/gfsbaskerville.sty:${PORTSDIR}/print/texlive-gfsbaskerville \
		${LOCALBASE}/share/texmf-dist/tex/latex/gfsporson/gfsporson.sty:${PORTSDIR}/print/texlive-gfsporson \
		${LOCALBASE}/share/texmf-dist/tex/latex/greek-inputenc/iso-8859-7.def:${PORTSDIR}/print/texlive-greek-inputenc \
		${LOCALBASE}/share/texmf-dist/tex/latex/greekdates/greekdates.sty:${PORTSDIR}/print/texlive-greekdates \
		${LOCALBASE}/share/texmf-dist/tex/latex/greektex/greektex.sty:${PORTSDIR}/print/texlive-greektex \
		${LOCALBASE}/share/texmf-dist/tex/latex/grverb/grverb.sty:${PORTSDIR}/print/texlive-grverb \
		${LOCALBASE}/share/texmf-dist/tex/latex/ibycus-babel/ibycus.ldf:${PORTSDIR}/print/texlive-ibycus-babel \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/ibygrk/fibb84.afm:${PORTSDIR}/print/texlive-ibygrk \
		${LOCALBASE}/share/texmf-dist/tex/latex/kerkis/kerkis.sty:${PORTSDIR}/print/texlive-kerkis \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/levy/a.mf:${PORTSDIR}/print/texlive-levy \
		${LOCALBASE}/share/texmf-dist/tex/latex/lgreek/lgreek.sty:${PORTSDIR}/print/texlive-lgreek \
		${LOCALBASE}/share/texmf-dist/makeindex/mkgrkindex/lowercase-headers.ist:${PORTSDIR}/print/texlive-mkgrkindex \
		${LOCALBASE}/share/texmf-dist/tex/latex/teubner/teubner.sty:${PORTSDIR}/print/texlive-teubner \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/xgreek/xgreek.sty:${PORTSDIR}/print/texlive-xgreek \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/yannisgr/csc_misce.mf:${PORTSDIR}/print/texlive-yannisgr \
		${LOCALBASE}/share/texmf/tex/generic/hyphen/grmhyph5.tex:${PORTSDIR}/print/texlive-hyphen-greek \
		${LOCALBASE}/share/texmf/tex/generic/hyphen/grahyph5.tex:${PORTSDIR}/print/texlive-hyphen-ancientgreek \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/tex/latex/apalike/apalike.sty:${PORTSDIR}/print/texlive-apalike \
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
		${LOCALBASE}/share/texmf/tex/generic/config/luatexiniconfig.tex:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf-dist/makeindex/base/din.ist:${PORTSDIR}/print/texlive-makeindex \
		${LOCALBASE}/share/texmf-dist/metafont/base/expr.mf:${PORTSDIR}/print/texlive-metafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/mflogo/mflogo.sty:${PORTSDIR}/print/texlive-mflogo \
		${LOCALBASE}/share/texmf-dist/mft/base/README:${PORTSDIR}/print/texlive-mfware \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/misc/black.mf:${PORTSDIR}/print/texlive-misc \
		${LOCALBASE}/share/texmf/fonts/map/pdftex/updmap/pdftex.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf/dvips/tetex/config.builtin35:${PORTSDIR}/print/texlive-tetex \
		${LOCALBASE}/share/texmf/texconfig/README:${PORTSDIR}/print/texlive-texconfig \
		${LOCALBASE}/share/texmf/scripts/texlive/lua/texlive/getopt.tlu:${PORTSDIR}/print/texlive-texlive-scripts \
		${LOCALBASE}/share/texmf/scripts/texlive/tlmgr.pl:${PORTSDIR}/print/texlive-texlive.infra \
		${LOCALBASE}/share/texmf/xdvi/XDvi:${PORTSDIR}/print/texlive-xdvi

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
