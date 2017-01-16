# $FreeBSD$

PORTNAME=	uplatex
PORTVERSION=	20161207
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	pLaTeX2e and miscellaneous macros for upTeX

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/uptex/uptex-base/euptex.ini:${PORTSDIR}/print/texlive-uptex-base \
		${LOCALBASE}/share/texmf-dist/fonts/cmap/uptex-fonts/UTF8-UTF16:${PORTSDIR}/print/texlive-uptex-fonts \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cm/cmtext-bsr-interpolated.map:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/knuth-lib/3test.mf:${PORTSDIR}/print/texlive-knuth-lib \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/etex/xbmc10.mf:${PORTSDIR}/print/texlive-etex \
		${LOCALBASE}/share/texmf-dist/tex/ptex/ptex-base/ascii-jplain.tex:${PORTSDIR}/print/texlive-ptex-base \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel/babel.sty:${PORTSDIR}/print/texlive-babel \
		${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/latex-fonts/circle.mf:${PORTSDIR}/print/texlive-latex-fonts

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
