# New ports collection makefile for:	texlive-scheme-context
# Date created:		26/01/2009 16:03:27
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	scheme-context
PORTREVISION=	1
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	ConTeXt scheme

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/context/base/context.tex:${PORTSDIR}/print/texlive-context \
		${LOCALBASE}/share/texmf-dist/fonts/afm/jmn/hans/hans-sh.afm:${PORTSDIR}/print/texlive-jmn \
		${LOCALBASE}/share/texmf-dist/fonts/truetype/hoekwater/lmextra/lmtypewriter10-regular.ttf:${PORTSDIR}/print/texlive-lmextra \
		${LOCALBASE}/share/texmf-dist/tex/mptopdf/config/mptopdf.ini:${PORTSDIR}/print/texlive-bin-context \
		${LOCALBASE}/share/texmf-dist/tex/context/interface/third/t-account.xml:${PORTSDIR}/print/texlive-context-account \
		${LOCALBASE}/share/texmf-dist/tex/context/third/bnf/t-bnf.tex:${PORTSDIR}/print/texlive-context-bnf \
		${LOCALBASE}/share/texmf-dist/tex/context/third/chromato/t-chromato.tex:${PORTSDIR}/print/texlive-context-chromato \
		${LOCALBASE}/share/texmf-dist/tex/context/third/construction-plan/t-construction-plan.tex:${PORTSDIR}/print/texlive-context-construction-plan \
		${LOCALBASE}/share/texmf-dist/tex/context/third/degrade/t-degrade.tex:${PORTSDIR}/print/texlive-context-degrade \
		${LOCALBASE}/share/texmf-dist/tex/context/third/french/t-french.tex:${PORTSDIR}/print/texlive-context-french \
		${LOCALBASE}/share/texmf-dist/metapost/context/third/gnuplot/mp-gnuplot.mp:${PORTSDIR}/print/texlive-context-gnuplot \
		${LOCALBASE}/share/texmf-dist/tex/context/interface/third/t-letter.xml:${PORTSDIR}/print/texlive-context-letter \
		${LOCALBASE}/share/texmf-dist/tex/context/interface/third/lettrine.xml:${PORTSDIR}/print/texlive-context-lettrine \
		${LOCALBASE}/share/texmf-dist/tex/context/third/lilypond/t-lilypond.tex:${PORTSDIR}/print/texlive-context-lilypond \
		${LOCALBASE}/share/texmf-dist/tex/context/interface/third/t-mathsets.xml:${PORTSDIR}/print/texlive-context-mathsets \
		${LOCALBASE}/share/texmf-dist/tex/context/third/taspresent/t-blackblue.tex:${PORTSDIR}/print/texlive-context-taspresent \
		${LOCALBASE}/share/texmf-dist/tex/context/third/typearea/t-typearea.tex:${PORTSDIR}/print/texlive-context-typearea \
		${LOCALBASE}/share/texmf-dist/tex/context/interface/third/t-vim.xml:${PORTSDIR}/print/texlive-context-vim \
		${LOCALBASE}/share/texmf-dist/metapost/automata/automata.mp:${PORTSDIR}/print/texlive-automata \
		${LOCALBASE}/share/texmf-dist/metapost/bbcard/bbcard.mp:${PORTSDIR}/print/texlive-bbcard \
		${LOCALBASE}/share/texmf-dist/metapost/blockdraw_mp/blockdraw.mp:${PORTSDIR}/print/texlive-blockdraw_mp \
		${LOCALBASE}/share/texmf-dist/metapost/bpolynomial/bpolynomial.mp:${PORTSDIR}/print/texlive-bpolynomial \
		${LOCALBASE}/share/texmf-dist/metapost/cmarrows/cmarrows.mp:${PORTSDIR}/print/texlive-cmarrows \
		${LOCALBASE}/share/texmf-dist/metapost/dviincl/fix_brks.mp:${PORTSDIR}/print/texlive-dviincl \
		${LOCALBASE}/share/texmf-dist/tex/latex/emp/emp.sty:${PORTSDIR}/print/texlive-emp \
		${LOCALBASE}/share/texmf-dist/metapost/epsincl/epsincl.mp:${PORTSDIR}/print/texlive-epsincl \
		${LOCALBASE}/share/texmf-dist/metapost/expressg/aam.mp:${PORTSDIR}/print/texlive-expressg \
		${LOCALBASE}/share/texmf-dist/metapost/exteps/exteps.mp:${PORTSDIR}/print/texlive-exteps \
		${LOCALBASE}/share/texmf-dist/metapost/featpost/featpost.mp:${PORTSDIR}/print/texlive-featpost \
		${LOCALBASE}/share/texmf-dist/tex/latex/feynmf/feynmf.sty:${PORTSDIR}/print/texlive-feynmf \
		${LOCALBASE}/share/texmf-dist/metapost/hatching/hatching.mp:${PORTSDIR}/print/texlive-hatching \
		${LOCALBASE}/share/texmf-dist/metapost/latexmp/latexmp.mp:${PORTSDIR}/print/texlive-latexmp \
		${LOCALBASE}/share/texmf-dist/metapost/metago/metago.mp:${PORTSDIR}/print/texlive-metago \
		${LOCALBASE}/share/texmf-dist/metapost/metaobj/connections.mp:${PORTSDIR}/print/texlive-metaobj \
		${LOCALBASE}/share/texmf-dist/metapost/metaplot/axes.mp:${PORTSDIR}/print/texlive-metaplot \
		${LOCALBASE}/share/texmf-dist/metapost/base/TEX.mp:${PORTSDIR}/print/texlive-metapost \
		${LOCALBASE}/share/texmf-dist/metapost/metauml/metauml.mp:${PORTSDIR}/print/texlive-metauml \
		${LOCALBASE}/share/texmf-dist/tex/generic/mfpic/mfpic.sty:${PORTSDIR}/print/texlive-mfpic \
		${LOCALBASE}/share/texmf-dist/tex/latex/mfpic4ode/mfpic4ode.sty:${PORTSDIR}/print/texlive-mfpic4ode \
		${LOCALBASE}/share/texmf-dist/metapost/mp3d/3d.mp:${PORTSDIR}/print/texlive-mp3d \
		${LOCALBASE}/share/texmf-dist/metapost/mpattern/mpattern.mp:${PORTSDIR}/print/texlive-mpattern \
		${LOCALBASE}/share/texmf-dist/metapost/piechartmp/piechartmp.mp:${PORTSDIR}/print/texlive-piechartmp \
		${LOCALBASE}/share/texmf-dist/metafont/roex/roex.mf:${PORTSDIR}/print/texlive-roex \
		${LOCALBASE}/share/texmf-dist/metapost/slideshow/pathalong.mp:${PORTSDIR}/print/texlive-slideshow \
		${LOCALBASE}/share/texmf-dist/metapost/splines/splines.mp:${PORTSDIR}/print/texlive-splines \
		${LOCALBASE}/share/texmf-dist/metapost/textpath/textpath.mp:${PORTSDIR}/print/texlive-textpath \
		${LOCALBASE}/share/texmf/fmtutil/format.metapost.cnf:${PORTSDIR}/print/texlive-bin-metapost \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/ams/amsj.bib:${PORTSDIR}/print/texlive-ams \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/base/xampl.bib:${PORTSDIR}/print/texlive-bibtex \
		${LOCALBASE}/share/texmf-dist/dvips/cm/config.cm:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cmex/ttcmex.map:${PORTSDIR}/print/texlive-cmex \
		${LOCALBASE}/share/texmf-dist/dvips/base/ehandler.ps:${PORTSDIR}/print/texlive-dvips \
		${LOCALBASE}/share/texmf-dist/tex/generic/enctex/1250-csf.tex:${PORTSDIR}/print/texlive-enctex \
		${LOCALBASE}/share/texmf-dist/tex/plain/etex/etex.src:${PORTSDIR}/print/texlive-etex \
		${LOCALBASE}/share/texmf-dist/tex/latex/etex-pkg/etex.sty:${PORTSDIR}/print/texlive-etex-pkg \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/tex/generic/ifxetex/ifxetex.sty:${PORTSDIR}/print/texlive-ifxetex \
		${LOCALBASE}/share/texmf-dist/makeindex/base/din.ist:${PORTSDIR}/print/texlive-makeindex \
		${LOCALBASE}/share/texmf-dist/metafont/base/expr.mf:${PORTSDIR}/print/texlive-metafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/mflogo/mflogo.sty:${PORTSDIR}/print/texlive-mflogo \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/misc/black.mf:${PORTSDIR}/print/texlive-misc \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-bin-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf/dvipdfm/config/config:${PORTSDIR}/print/texlive-bin-dvipdfm \
		${LOCALBASE}/share/texmf/dvipdfmx/dvipdfmx.cfg:${PORTSDIR}/print/texlive-bin-dvipdfmx \
		${LOCALBASE}/share/texmf/dvips/base/color.pro:${PORTSDIR}/print/texlive-bin-dvipsk \
		${LOCALBASE}/share/texmf/scripts/texlive/getnonfreefonts.pl:${PORTSDIR}/print/texlive-bin-getnonfreefonts \
		${LOCALBASE}/share/texmf/dvips/gsftopk/render.ps:${PORTSDIR}/print/texlive-bin-gsftopk \
		${LOCALBASE}/share/texmf/fmtutil/format.metafont.cnf:${PORTSDIR}/print/texlive-bin-metafont \
		${LOCALBASE}/share/texmf/dvips/tetex/config.builtin35:${PORTSDIR}/print/texlive-bin-tetex \
		${LOCALBASE}/share/texmf/fmtutil/fmtutil-hdr.cnf:${PORTSDIR}/print/texlive-bin-texlive \
		${LOCALBASE}/share/texmf/fmtutil/format.tex.cnf:${PORTSDIR}/print/texlive-bin-tex \
		${LOCALBASE}/share/texmf/texconfig/README:${PORTSDIR}/print/texlive-bin-texconfig \
		${LOCALBASE}/share/texmf/xdvi/XDvi:${PORTSDIR}/print/texlive-bin-xdvi \
		${LOCALBASE}/share/texmf-dist/tex/latex/dvipdfmx-def/dvipdfmx.def:${PORTSDIR}/print/texlive-dvipdfmx-def \
		${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/share/texmf/fmtutil/format.luatex.cnf:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf/fmtutil/format.pdftex.cnf:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/fonts/misc/xetex/fontmapping/base/qx-unicode.map:${PORTSDIR}/print/texlive-xetex \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/tex-gyre/qagb.afm:${PORTSDIR}/print/texlive-tex-gyre \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/antt/anttb.afm:${PORTSDIR}/print/texlive-antt \
		${LOCALBASE}/share/texmf-dist/dvips/antp/antp.cfg:${PORTSDIR}/print/texlive-antp \
		${LOCALBASE}/share/texmf-dist/tex/latex/iwona/iwona.sty:${PORTSDIR}/print/texlive-iwona \
		${LOCALBASE}/share/texmf-dist/tex/latex/kurier/kurier.sty:${PORTSDIR}/print/texlive-kurier \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/lm/lmb10.afm:${PORTSDIR}/print/texlive-lm

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
