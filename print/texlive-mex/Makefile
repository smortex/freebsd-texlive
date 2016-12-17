# $FreeBSD$

PORTNAME=	mex
PORTVERSION=	20160503
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Polish formats for TeX

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/dvips/pl/config.pl:${PORTSDIR}/print/texlive-pl \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/loadhyph/loadhyph-pl.tex:${PORTSDIR}/print/texlive-hyphen-polish \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/dummy-space/dummy-space.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cm/cmtext-bsr-interpolated.map:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/knuth-lib/3test.mf:${PORTSDIR}/print/texlive-knuth-lib \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
