# New ports collection makefile for:	texlive-collection-binextra
# Date created:		26/01/2009 16:03:48
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	collection-binextra
PORTREVISION=	11
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	TeX auxiliary programs

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bib/ams/amsj.bib:${PORTSDIR}/print/texlive-ams \
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
		${LOCALBASE}/share/texmf/scripts/a2ping/a2ping.pl:${PORTSDIR}/print/texlive-a2ping \
		${LOCALBASE}/share/texmf-dist/bibtex/csf/base/88591lat.csf:${PORTSDIR}/print/texlive-bin-bibtex8 \
		${LOCALBASE}/share/texmf/doc/man/man1/dt2dv.1:${PORTSDIR}/print/texlive-bin-dtl \
		${LOCALBASE}/share/texmf/doc/man/man1/dvi2tty.1:${PORTSDIR}/print/texlive-bin-dvi2tty \
		${LOCALBASE}/share/texmf/doc/man/man1/dvidvi.1:${PORTSDIR}/print/texlive-bin-dvidvi \
		${LOCALBASE}/share/texmf/doc/man/man1/lacheck.1:${PORTSDIR}/print/texlive-bin-lacheck \
		${LOCALBASE}/share/texmf/scripts/epstopdf/epstopdf.pl:${PORTSDIR}/print/texlive-bin-pdftools \
		${LOCALBASE}/share/texmf/doc/man/man1/dvibook.1:${PORTSDIR}/print/texlive-bin-seetexk \
		${LOCALBASE}/share/texmf/scripts/tetex/texdoctk.pl:${PORTSDIR}/print/texlive-bin-texdoc \
		${LOCALBASE}/share/texmf-dist/tex/plain/cweb/cwebmac.tex:${PORTSDIR}/print/texlive-cweb \
		${LOCALBASE}/share/texmf-dist/scripts/dviasm/dviasm.py:${PORTSDIR}/print/texlive-dviasm \
		${LOCALBASE}/share/texmf-dist/tex/latex/latex2man/latex2man.sty:${PORTSDIR}/print/texlive-latex2man \
		${LOCALBASE}/share/texmf-dist/scripts/latexmk/latexmk.pl:${PORTSDIR}/print/texlive-latexmk \
		${LOCALBASE}/share/texmf-dist/makeindex/mkind-english/digit.ist:${PORTSDIR}/print/texlive-mkind-english \
		${LOCALBASE}/share/texmf-dist/scripts/mkjobtexmf/mkjobtexmf.pl:${PORTSDIR}/print/texlive-mkjobtexmf \
		${LOCALBASE}/share/texmf-dist/scripts/pdfcrop/pdfcrop.pl:${PORTSDIR}/print/texlive-pdfcrop \
		${LOCALBASE}/share/texmf-dist/scripts/texcount/TeXcount.pl:${PORTSDIR}/print/texlive-texcount \
		${LOCALBASE}/share/texmf/scripts/xindy/texindy.pl:${PORTSDIR}/print/texlive-xindy

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
