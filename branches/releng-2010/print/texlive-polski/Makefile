# New ports collection makefile for:	texlive-polski
# Date created:		13/03/2010 04:37:52
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	polski
PORTVERSION=	20100922
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Typeset Polish documents with LaTeX and Polish fonts.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/dvips/pl/config.pl:${PORTSDIR}/print/texlive-pl \
		${LOCALBASE}/share/texmf/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8


.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
