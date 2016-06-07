# $FreeBSD$

PORTNAME=	polski
PORTVERSION=	20160414
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Typeset Polish documents with LaTeX and Polish fonts

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/dvips/pl/config.pl:${PORTSDIR}/print/texlive-pl \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/loadhyph/loadhyph-pl.tex:${PORTSDIR}/print/texlive-hyphen-polish

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
