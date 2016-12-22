# $FreeBSD$

PORTNAME=	latex-bin
PORTVERSION=	20161222
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	LaTeX executables and man pages.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel/babel.sty:${PORTSDIR}/print/texlive-babel \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cm/cmtext-bsr-interpolated.map:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/latex-fonts/circle.mf:${PORTSDIR}/print/texlive-latex-fonts \
		${LOCALBASE}/share/texmf-dist/tex/generic/tex-ini-files/dvilualatex.ini:${PORTSDIR}/print/texlive-tex-ini-files \
		${LOCALBASE}/share/texmf-dist/tex/latex/latexconfig/epstopdf-sys.cfg:${PORTSDIR}/print/texlive-latexconfig \
		${LOCALBASE}/share/texmf-dist/tex/generic/unicode-data/CaseFolding.txt:${PORTSDIR}/print/texlive-unicode-data \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
