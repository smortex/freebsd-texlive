# New ports collection makefile for:	texlive-collection-context
# Date created:		13/03/2010 04:22:27
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	collection-context
PORTVERSION=	20101110
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	ConTeXt format

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/context/base/context.tex:${PORTSDIR}/print/texlive-context \
		${LOCALBASE}/share/texmf-dist/fonts/afm/jmn/hans/hans-sh.afm:${PORTSDIR}/print/texlive-jmn \
		${LOCALBASE}/share/texmf-dist/fonts/truetype/hoekwater/lmextra/lmtypewriter10-regular.ttf:${PORTSDIR}/print/texlive-lmextra \
		${LOCALBASE}/share/texmf-dist/tex/context/interface/third/t-account.xml:${PORTSDIR}/print/texlive-context-account \
		${LOCALBASE}/share/texmf-dist/tex/context/third/algorithmic/t-algorithmic.tex:${PORTSDIR}/print/texlive-context-algorithmic \
		${LOCALBASE}/share/texmf-dist/tex/context/third/bnf/t-bnf.tex:${PORTSDIR}/print/texlive-context-bnf \
		${LOCALBASE}/share/texmf-dist/tex/context/third/chromato/t-chromato.tex:${PORTSDIR}/print/texlive-context-chromato \
		${LOCALBASE}/share/texmf-dist/tex/context/third/construction-plan/t-construction-plan.tex:${PORTSDIR}/print/texlive-context-construction-plan \
		${LOCALBASE}/share/texmf-dist/tex/context/third/degrade/t-degrade.tex:${PORTSDIR}/print/texlive-context-degrade \
		${LOCALBASE}/share/texmf-dist/tex/context/third/filter/t-filter.tex:${PORTSDIR}/print/texlive-context-filter \
		${LOCALBASE}/share/texmf-dist/tex/context/third/fixme/t-fixme.tex:${PORTSDIR}/print/texlive-context-fixme \
		${LOCALBASE}/share/texmf-dist/tex/context/third/french/t-french.tex:${PORTSDIR}/print/texlive-context-french \
		${LOCALBASE}/share/texmf-dist/tex/context/third/fullpage/t-fullpage.tex:${PORTSDIR}/print/texlive-context-fullpage \
		${LOCALBASE}/share/texmf-dist/tex/context/third/games/games-go.lua:${PORTSDIR}/print/texlive-context-games \
		${LOCALBASE}/share/texmf-dist/metapost/context/third/gnuplot/mp-gnuplot.mp:${PORTSDIR}/print/texlive-context-gnuplot \
		${LOCALBASE}/share/texmf-dist/tex/context/interface/third/t-letter.xml:${PORTSDIR}/print/texlive-context-letter \
		${LOCALBASE}/share/texmf-dist/tex/context/interface/third/lettrine.xml:${PORTSDIR}/print/texlive-context-lettrine \
		${LOCALBASE}/share/texmf-dist/tex/context/third/lilypond/t-lilypond.tex:${PORTSDIR}/print/texlive-context-lilypond \
		${LOCALBASE}/share/texmf-dist/tex/context/interface/third/t-mathsets.xml:${PORTSDIR}/print/texlive-context-mathsets \
		${LOCALBASE}/share/texmf-dist/tex/context/third/ruby/t-ruby.tex:${PORTSDIR}/print/texlive-context-ruby \
		${LOCALBASE}/share/texmf-dist/tex/context/third/simplefonts/t-simplefonts.lua:${PORTSDIR}/print/texlive-context-simplefonts \
		${LOCALBASE}/share/texmf-dist/tex/context/interface/third/t-simpleslides.xml:${PORTSDIR}/print/texlive-context-simpleslides \
		${LOCALBASE}/share/texmf-dist/tex/context/third/typearea/t-typearea.tex:${PORTSDIR}/print/texlive-context-typearea \
		${LOCALBASE}/share/texmf-dist/tex/context/third/typescripts/type-adobe.mkii:${PORTSDIR}/print/texlive-context-typescripts \
		${LOCALBASE}/share/texmf-dist/tex/context/interface/third/t-vim.xml:${PORTSDIR}/print/texlive-context-vim \
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
		${LOCALBASE}/share/texmf/tex/generic/config/luatex-unicode-letters.tex:${PORTSDIR}/print/texlive-luatex \
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
